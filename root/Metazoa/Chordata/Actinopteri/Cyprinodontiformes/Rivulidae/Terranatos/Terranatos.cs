using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Terranatos;

/// <summary>
/// Abstract class for Terranatos (genus).
/// NCBI TaxId: 61835
/// </summary>
public abstract class Terranatos : Rivulidae, ITerranatos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terranatos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61835;

    /// <inheritdoc />
    public virtual string GenusName => "Terranatos";

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
