using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Scomberoides;

/// <summary>
/// Abstract class for Scomberoides (genus).
/// NCBI TaxId: 173340
/// </summary>
public abstract class Scomberoides : Carangidae, IScomberoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scomberoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173340;

    /// <inheritdoc />
    public virtual string GenusName => "Scomberoides";

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
