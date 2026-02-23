using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Humerana;

/// <summary>
/// Abstract class for Humerana (genus).
/// NCBI TaxId: 1659744
/// </summary>
public abstract class Humerana : Ranidae, IHumerana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Humerana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1659744;

    /// <inheritdoc />
    public virtual string GenusName => "Humerana";

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
