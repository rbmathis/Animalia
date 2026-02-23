using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

/// <summary>
/// Abstract class for Raja (genus).
/// NCBI TaxId: 7780
/// </summary>
public abstract class Raja : Rajidae, IRaja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7780;

    /// <inheritdoc />
    public virtual string GenusName => "Raja";

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
