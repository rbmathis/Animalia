using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eurylaimidae.Serilophus;

/// <summary>
/// Abstract class for Serilophus (genus).
/// NCBI TaxId: 239383
/// </summary>
public abstract class Serilophus : Eurylaimidae, ISerilophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serilophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 239383;

    /// <inheritdoc />
    public virtual string GenusName => "Serilophus";

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
