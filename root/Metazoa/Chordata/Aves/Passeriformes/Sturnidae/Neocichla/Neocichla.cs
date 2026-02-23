using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Neocichla;

/// <summary>
/// Abstract class for Neocichla (genus).
/// NCBI TaxId: 311364
/// </summary>
public abstract class Neocichla : Sturnidae, INeocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311364;

    /// <inheritdoc />
    public virtual string GenusName => "Neocichla";

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
