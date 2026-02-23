using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Ophisternon;

/// <summary>
/// Abstract class for Ophisternon (genus).
/// NCBI TaxId: 205851
/// </summary>
public abstract class Ophisternon : Synbranchidae, IOphisternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophisternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205851;

    /// <inheritdoc />
    public virtual string GenusName => "Ophisternon";

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
