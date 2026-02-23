using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Badis;

/// <summary>
/// Abstract class for Badis (genus).
/// NCBI TaxId: 248957
/// </summary>
public abstract class Badis : Badidae, IBadis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Badis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248957;

    /// <inheritdoc />
    public virtual string GenusName => "Badis";

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
