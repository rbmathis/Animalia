using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae.Cymatognathus;

/// <summary>
/// Abstract class for Cymatognathus (genus).
/// NCBI TaxId: 3022025
/// </summary>
public abstract class Cymatognathus : Symphysanodontidae, ICymatognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cymatognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3022025;

    /// <inheritdoc />
    public virtual string GenusName => "Cymatognathus";

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
