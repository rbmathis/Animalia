using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Chilobrycon;

/// <summary>
/// Abstract class for Chilobrycon (genus).
/// NCBI TaxId: 1529847
/// </summary>
public abstract class Chilobrycon : Bryconidae, IChilobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1529847;

    /// <inheritdoc />
    public virtual string GenusName => "Chilobrycon";

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
