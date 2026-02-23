using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Melocichla;

/// <summary>
/// Abstract class for Melocichla (genus).
/// NCBI TaxId: 330759
/// </summary>
public abstract class Melocichla : Sylviidae, IMelocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330759;

    /// <inheritdoc />
    public virtual string GenusName => "Melocichla";

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
