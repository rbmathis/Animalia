using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Haematortyx;

/// <summary>
/// Abstract class for Haematortyx (genus).
/// NCBI TaxId: 475775
/// </summary>
public abstract class Haematortyx : Phasianidae, IHaematortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haematortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 475775;

    /// <inheritdoc />
    public virtual string GenusName => "Haematortyx";

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
