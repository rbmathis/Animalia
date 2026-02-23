using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Polyacanthonotus;

/// <summary>
/// Abstract class for Polyacanthonotus (genus).
/// NCBI TaxId: 391224
/// </summary>
public abstract class Polyacanthonotus : Notacanthidae, IPolyacanthonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyacanthonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391224;

    /// <inheritdoc />
    public virtual string GenusName => "Polyacanthonotus";

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
