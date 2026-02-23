using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Sigmops;

/// <summary>
/// Abstract class for Sigmops (genus).
/// NCBI TaxId: 505324
/// </summary>
public abstract class Sigmops : Gonostomatidae, ISigmops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sigmops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 505324;

    /// <inheritdoc />
    public virtual string GenusName => "Sigmops";

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
