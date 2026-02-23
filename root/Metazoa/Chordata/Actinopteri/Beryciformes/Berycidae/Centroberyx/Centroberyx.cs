using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Berycidae.Centroberyx;

/// <summary>
/// Abstract class for Centroberyx (genus).
/// NCBI TaxId: 88664
/// </summary>
public abstract class Centroberyx : Berycidae, ICentroberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centroberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88664;

    /// <inheritdoc />
    public virtual string GenusName => "Centroberyx";

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
