using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Galerida;

/// <summary>
/// Abstract class for Galerida (genus).
/// NCBI TaxId: 215305
/// </summary>
public abstract class Galerida : Alaudidae, IGalerida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galerida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215305;

    /// <inheritdoc />
    public virtual string GenusName => "Galerida";

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
