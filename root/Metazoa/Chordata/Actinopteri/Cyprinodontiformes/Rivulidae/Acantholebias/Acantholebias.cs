using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Acantholebias;

/// <summary>
/// Abstract class for Acantholebias (genus).
/// NCBI TaxId: 3567761
/// </summary>
public abstract class Acantholebias : Rivulidae, IAcantholebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acantholebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3567761;

    /// <inheritdoc />
    public virtual string GenusName => "Acantholebias";

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
