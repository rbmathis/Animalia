using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Basilornis;

/// <summary>
/// Abstract class for Basilornis (genus).
/// NCBI TaxId: 451429
/// </summary>
public abstract class Basilornis : Sturnidae, IBasilornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Basilornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451429;

    /// <inheritdoc />
    public virtual string GenusName => "Basilornis";

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
