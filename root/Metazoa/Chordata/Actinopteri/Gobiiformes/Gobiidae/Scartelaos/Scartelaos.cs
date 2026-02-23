using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Scartelaos;

/// <summary>
/// Abstract class for Scartelaos (genus).
/// NCBI TaxId: 166763
/// </summary>
public abstract class Scartelaos : Gobiidae, IScartelaos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scartelaos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166763;

    /// <inheritdoc />
    public virtual string GenusName => "Scartelaos";

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
