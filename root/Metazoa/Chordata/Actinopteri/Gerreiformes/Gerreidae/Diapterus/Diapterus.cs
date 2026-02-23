using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Diapterus;

/// <summary>
/// Abstract class for Diapterus (genus).
/// NCBI TaxId: 334384
/// </summary>
public abstract class Diapterus : Gerreidae, IDiapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334384;

    /// <inheritdoc />
    public virtual string GenusName => "Diapterus";

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
