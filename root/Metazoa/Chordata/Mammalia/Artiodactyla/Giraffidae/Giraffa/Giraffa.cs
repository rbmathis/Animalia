using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Giraffidae.Giraffa;

/// <summary>
/// Abstract class for Giraffa (genus).
/// NCBI TaxId: 9893
/// </summary>
public abstract class Giraffa : Giraffidae, IGiraffa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Giraffa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9893;

    /// <inheritdoc />
    public virtual string GenusName => "Giraffa";

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
