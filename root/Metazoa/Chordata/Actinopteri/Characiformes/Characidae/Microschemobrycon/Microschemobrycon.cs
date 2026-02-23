using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Microschemobrycon;

/// <summary>
/// Abstract class for Microschemobrycon (genus).
/// NCBI TaxId: 930353
/// </summary>
public abstract class Microschemobrycon : Characidae, IMicroschemobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microschemobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930353;

    /// <inheritdoc />
    public virtual string GenusName => "Microschemobrycon";

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
