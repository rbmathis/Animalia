using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Dama;

/// <summary>
/// Abstract class for Dama (genus).
/// NCBI TaxId: 9867
/// </summary>
public abstract class Dama : Cervidae, IDama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9867;

    /// <inheritdoc />
    public virtual string GenusName => "Dama";

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
