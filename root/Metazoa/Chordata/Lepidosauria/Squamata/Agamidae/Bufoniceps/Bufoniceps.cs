using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Bufoniceps;

/// <summary>
/// Abstract class for Bufoniceps (genus).
/// NCBI TaxId: 330739
/// </summary>
public abstract class Bufoniceps : Agamidae, IBufoniceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bufoniceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330739;

    /// <inheritdoc />
    public virtual string GenusName => "Bufoniceps";

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
