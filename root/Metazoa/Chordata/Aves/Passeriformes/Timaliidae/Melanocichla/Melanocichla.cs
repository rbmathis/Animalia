using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Melanocichla;

/// <summary>
/// Abstract class for Melanocichla (genus).
/// NCBI TaxId: 3150854
/// </summary>
public abstract class Melanocichla : Timaliidae, IMelanocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150854;

    /// <inheritdoc />
    public virtual string GenusName => "Melanocichla";

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
