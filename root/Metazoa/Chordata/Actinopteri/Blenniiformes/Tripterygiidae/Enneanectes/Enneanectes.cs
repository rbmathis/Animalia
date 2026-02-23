using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Enneanectes;

/// <summary>
/// Abstract class for Enneanectes (genus).
/// NCBI TaxId: 722435
/// </summary>
public abstract class Enneanectes : Tripterygiidae, IEnneanectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enneanectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722435;

    /// <inheritdoc />
    public virtual string GenusName => "Enneanectes";

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
