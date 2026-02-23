using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Leptochariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Leptochariidae.Leptocharias;

/// <summary>
/// Abstract class for Leptocharias (genus).
/// NCBI TaxId: 376641
/// </summary>
public abstract class Leptocharias : Leptochariidae, ILeptocharias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptocharias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376641;

    /// <inheritdoc />
    public virtual string GenusName => "Leptocharias";

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
