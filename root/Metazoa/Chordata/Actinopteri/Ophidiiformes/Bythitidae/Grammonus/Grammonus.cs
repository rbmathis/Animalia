using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Grammonus;

/// <summary>
/// Abstract class for Grammonus (genus).
/// NCBI TaxId: 2012962
/// </summary>
public abstract class Grammonus : Bythitidae, IGrammonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grammonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2012962;

    /// <inheritdoc />
    public virtual string GenusName => "Grammonus";

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
