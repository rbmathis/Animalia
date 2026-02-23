using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Loxioides;

/// <summary>
/// Abstract class for Loxioides (genus).
/// NCBI TaxId: 286691
/// </summary>
public abstract class Loxioides : Fringillidae, ILoxioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286691;

    /// <inheritdoc />
    public virtual string GenusName => "Loxioides";

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
