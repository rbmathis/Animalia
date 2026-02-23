using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Ibycter;

/// <summary>
/// Abstract class for Ibycter (genus).
/// NCBI TaxId: 2219151
/// </summary>
public abstract class Ibycter : Falconidae, IIbycter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ibycter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2219151;

    /// <inheritdoc />
    public virtual string GenusName => "Ibycter";

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
