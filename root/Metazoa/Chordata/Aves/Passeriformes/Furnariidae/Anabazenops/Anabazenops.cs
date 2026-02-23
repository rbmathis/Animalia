using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Anabazenops;

/// <summary>
/// Abstract class for Anabazenops (genus).
/// NCBI TaxId: 589934
/// </summary>
public abstract class Anabazenops : Furnariidae, IAnabazenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anabazenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589934;

    /// <inheritdoc />
    public virtual string GenusName => "Anabazenops";

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
