using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Minla;

/// <summary>
/// Abstract class for Minla (genus).
/// NCBI TaxId: 201346
/// </summary>
public abstract class Minla : Leiothrichidae, IMinla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201346;

    /// <inheritdoc />
    public virtual string GenusName => "Minla";

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
