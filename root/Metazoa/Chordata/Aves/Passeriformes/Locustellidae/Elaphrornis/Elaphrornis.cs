using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Elaphrornis;

/// <summary>
/// Abstract class for Elaphrornis (genus).
/// NCBI TaxId: 2162878
/// </summary>
public abstract class Elaphrornis : Locustellidae, IElaphrornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elaphrornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2162878;

    /// <inheritdoc />
    public virtual string GenusName => "Elaphrornis";

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
