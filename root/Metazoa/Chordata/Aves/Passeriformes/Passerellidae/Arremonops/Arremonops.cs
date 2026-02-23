using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Arremonops;

/// <summary>
/// Abstract class for Arremonops (genus).
/// NCBI TaxId: 95652
/// </summary>
public abstract class Arremonops : Passerellidae, IArremonops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arremonops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95652;

    /// <inheritdoc />
    public virtual string GenusName => "Arremonops";

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
