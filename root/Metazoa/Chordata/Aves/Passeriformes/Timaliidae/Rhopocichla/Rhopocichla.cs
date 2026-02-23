using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Rhopocichla;

/// <summary>
/// Abstract class for Rhopocichla (genus).
/// NCBI TaxId: 1149665
/// </summary>
public abstract class Rhopocichla : Timaliidae, IRhopocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhopocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1149665;

    /// <inheritdoc />
    public virtual string GenusName => "Rhopocichla";

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
