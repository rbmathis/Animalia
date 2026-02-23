using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Leptodeira;

/// <summary>
/// Abstract class for Leptodeira (genus).
/// NCBI TaxId: 121345
/// </summary>
public abstract class Leptodeira : Dipsadidae, ILeptodeira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptodeira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121345;

    /// <inheritdoc />
    public virtual string GenusName => "Leptodeira";

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
