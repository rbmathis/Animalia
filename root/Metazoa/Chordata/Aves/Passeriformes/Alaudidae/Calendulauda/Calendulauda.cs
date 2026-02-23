using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Calendulauda;

/// <summary>
/// Abstract class for Calendulauda (genus).
/// NCBI TaxId: 1364976
/// </summary>
public abstract class Calendulauda : Alaudidae, ICalendulauda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calendulauda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1364976;

    /// <inheritdoc />
    public virtual string GenusName => "Calendulauda";

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
