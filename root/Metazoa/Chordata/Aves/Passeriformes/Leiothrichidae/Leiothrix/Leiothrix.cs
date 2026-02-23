using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Leiothrix;

/// <summary>
/// Abstract class for Leiothrix (genus).
/// NCBI TaxId: 36274
/// </summary>
public abstract class Leiothrix : Leiothrichidae, ILeiothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36274;

    /// <inheritdoc />
    public virtual string GenusName => "Leiothrix";

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
