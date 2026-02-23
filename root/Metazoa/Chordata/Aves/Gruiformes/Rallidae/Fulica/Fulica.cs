using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Fulica;

/// <summary>
/// Abstract class for Fulica (genus).
/// NCBI TaxId: 9120
/// </summary>
public abstract class Fulica : Rallidae, IFulica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fulica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9120;

    /// <inheritdoc />
    public virtual string GenusName => "Fulica";

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
