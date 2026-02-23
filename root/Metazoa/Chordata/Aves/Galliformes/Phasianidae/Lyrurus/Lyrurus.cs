using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lyrurus;

/// <summary>
/// Abstract class for Lyrurus (genus).
/// NCBI TaxId: 1233215
/// </summary>
public abstract class Lyrurus : Phasianidae, ILyrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233215;

    /// <inheritdoc />
    public virtual string GenusName => "Lyrurus";

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
