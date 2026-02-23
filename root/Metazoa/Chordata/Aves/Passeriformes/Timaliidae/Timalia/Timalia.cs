using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Timalia;

/// <summary>
/// Abstract class for Timalia (genus).
/// NCBI TaxId: 201366
/// </summary>
public abstract class Timalia : Timaliidae, ITimalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Timalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201366;

    /// <inheritdoc />
    public virtual string GenusName => "Timalia";

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
