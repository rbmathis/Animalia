using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Hymenops;

/// <summary>
/// Abstract class for Hymenops (genus).
/// NCBI TaxId: 495236
/// </summary>
public abstract class Hymenops : Tyrannidae, IHymenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hymenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495236;

    /// <inheritdoc />
    public virtual string GenusName => "Hymenops";

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
