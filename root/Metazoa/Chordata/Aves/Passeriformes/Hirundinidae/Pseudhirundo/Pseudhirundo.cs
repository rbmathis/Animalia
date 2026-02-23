using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Pseudhirundo;

/// <summary>
/// Abstract class for Pseudhirundo (genus).
/// NCBI TaxId: 88121
/// </summary>
public abstract class Pseudhirundo : Hirundinidae, IPseudhirundo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudhirundo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88121;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudhirundo";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
