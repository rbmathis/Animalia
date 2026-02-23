using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Rynchops;

/// <summary>
/// Abstract class for Rynchops (genus).
/// NCBI TaxId: 227183
/// </summary>
public abstract class Rynchops : Laridae, IRynchops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rynchops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227183;

    /// <inheritdoc />
    public virtual string GenusName => "Rynchops";

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
