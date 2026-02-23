using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Orcaella;

/// <summary>
/// Abstract class for Orcaella (genus).
/// NCBI TaxId: 48746
/// </summary>
public abstract class Orcaella : Delphinidae, IOrcaella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orcaella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48746;

    /// <inheritdoc />
    public virtual string GenusName => "Orcaella";

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
