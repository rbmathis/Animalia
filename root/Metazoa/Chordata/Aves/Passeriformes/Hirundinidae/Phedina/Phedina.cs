using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Phedina;

/// <summary>
/// Abstract class for Phedina (genus).
/// NCBI TaxId: 317106
/// </summary>
public abstract class Phedina : Hirundinidae, IPhedina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phedina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317106;

    /// <inheritdoc />
    public virtual string GenusName => "Phedina";

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
