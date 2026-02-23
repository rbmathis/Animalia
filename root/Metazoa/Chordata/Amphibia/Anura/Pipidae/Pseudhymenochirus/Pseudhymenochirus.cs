using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pseudhymenochirus;

/// <summary>
/// Abstract class for Pseudhymenochirus (genus).
/// NCBI TaxId: 864176
/// </summary>
public abstract class Pseudhymenochirus : Pipidae, IPseudhymenochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudhymenochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 864176;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudhymenochirus";

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
