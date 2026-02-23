using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Caraibops;

/// <summary>
/// Abstract class for Caraibops (genus).
/// NCBI TaxId: 3362135
/// </summary>
public abstract class Caraibops : Acropomatidae, ICaraibops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caraibops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362135;

    /// <inheritdoc />
    public virtual string GenusName => "Caraibops";

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
