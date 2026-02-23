using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cunningtonia;

/// <summary>
/// Abstract class for Cunningtonia (genus).
/// NCBI TaxId: 27738
/// </summary>
public abstract class Cunningtonia : Cichlidae, ICunningtonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cunningtonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27738;

    /// <inheritdoc />
    public virtual string GenusName => "Cunningtonia";

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
