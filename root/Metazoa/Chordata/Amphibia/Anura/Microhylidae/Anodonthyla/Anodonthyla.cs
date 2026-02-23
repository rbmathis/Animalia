using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anodonthyla;

/// <summary>
/// Abstract class for Anodonthyla (genus).
/// NCBI TaxId: 161856
/// </summary>
public abstract class Anodonthyla : Microhylidae, IAnodonthyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anodonthyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161856;

    /// <inheritdoc />
    public virtual string GenusName => "Anodonthyla";

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
