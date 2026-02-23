using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Alectoris;

/// <summary>
/// Abstract class for Alectoris (genus).
/// NCBI TaxId: 9077
/// </summary>
public abstract class Alectoris : Phasianidae, IAlectoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alectoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9077;

    /// <inheritdoc />
    public virtual string GenusName => "Alectoris";

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
