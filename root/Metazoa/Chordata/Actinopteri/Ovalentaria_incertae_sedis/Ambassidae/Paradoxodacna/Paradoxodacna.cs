using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Ambassidae.Paradoxodacna;

/// <summary>
/// Abstract class for Paradoxodacna (genus).
/// NCBI TaxId: 2904769
/// </summary>
public abstract class Paradoxodacna : Ambassidae, IParadoxodacna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paradoxodacna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2904769;

    /// <inheritdoc />
    public virtual string GenusName => "Paradoxodacna";

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
