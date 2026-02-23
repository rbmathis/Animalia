using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Calyptocichla;

/// <summary>
/// Abstract class for Calyptocichla (genus).
/// NCBI TaxId: 374639
/// </summary>
public abstract class Calyptocichla : Pycnonotidae, ICalyptocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374639;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptocichla";

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
