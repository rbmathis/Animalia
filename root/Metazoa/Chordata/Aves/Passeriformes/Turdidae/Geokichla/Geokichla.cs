using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Geokichla;

/// <summary>
/// Abstract class for Geokichla (genus).
/// NCBI TaxId: 1743269
/// </summary>
public abstract class Geokichla : Turdidae, IGeokichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geokichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743269;

    /// <inheritdoc />
    public virtual string GenusName => "Geokichla";

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
