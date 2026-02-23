using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Ptilocichla;

/// <summary>
/// Abstract class for Ptilocichla (genus).
/// NCBI TaxId: 1149658
/// </summary>
public abstract class Ptilocichla : Timaliidae, IPtilocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1149658;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilocichla";

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
