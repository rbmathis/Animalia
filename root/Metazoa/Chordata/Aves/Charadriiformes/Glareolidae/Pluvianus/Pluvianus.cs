using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Glareolidae.Pluvianus;

/// <summary>
/// Abstract class for Pluvianus (genus).
/// NCBI TaxId: 302530
/// </summary>
public abstract class Pluvianus : Glareolidae, IPluvianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pluvianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302530;

    /// <inheritdoc />
    public virtual string GenusName => "Pluvianus";

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
