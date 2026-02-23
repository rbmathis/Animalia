using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Carchariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Carchariidae.Carcharias;

/// <summary>
/// Abstract class for Carcharias (genus).
/// NCBI TaxId: 30500
/// </summary>
public abstract class Carcharias : Carchariidae, ICarcharias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carcharias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30500;

    /// <inheritdoc />
    public virtual string GenusName => "Carcharias";

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
