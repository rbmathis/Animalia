using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Lamprotornis;

/// <summary>
/// Abstract class for Lamprotornis (genus).
/// NCBI TaxId: 85070
/// </summary>
public abstract class Lamprotornis : Sturnidae, ILamprotornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamprotornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85070;

    /// <inheritdoc />
    public virtual string GenusName => "Lamprotornis";

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
