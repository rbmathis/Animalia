using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Leucopternis;

/// <summary>
/// Abstract class for Leucopternis (genus).
/// NCBI TaxId: 321092
/// </summary>
public abstract class Leucopternis : Accipitridae, ILeucopternis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucopternis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321092;

    /// <inheritdoc />
    public virtual string GenusName => "Leucopternis";

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
