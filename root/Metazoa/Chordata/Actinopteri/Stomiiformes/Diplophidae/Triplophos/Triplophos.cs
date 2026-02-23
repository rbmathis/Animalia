using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae.Triplophos;

/// <summary>
/// Abstract class for Triplophos (genus).
/// NCBI TaxId: 882891
/// </summary>
public abstract class Triplophos : Diplophidae, ITriplophos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triplophos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882891;

    /// <inheritdoc />
    public virtual string GenusName => "Triplophos";

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
