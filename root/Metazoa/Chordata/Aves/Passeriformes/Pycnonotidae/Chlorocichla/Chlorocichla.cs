using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Chlorocichla;

/// <summary>
/// Abstract class for Chlorocichla (genus).
/// NCBI TaxId: 181091
/// </summary>
public abstract class Chlorocichla : Pycnonotidae, IChlorocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181091;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorocichla";

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
